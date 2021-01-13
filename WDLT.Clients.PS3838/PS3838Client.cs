using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.PS3838.Enums;
using WDLT.Clients.PS3838.Models;

namespace WDLT.Clients.PS3838
{
    public class PS3838Client : BaseClient
    {
        public PS3838Client(string userAgent) : base("https://api.ps3838.com/", userAgent) { }

        public void Auth(string username, string password)
        {
            var us = $"{username}:{password}";
            _client.AddDefaultHeader("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes(us))}");
        }

        public Task<PS3838FixturesResponse> FixturesV3Async(EPS3838Sport sport, bool onlyLive = false,
            IEnumerable<int> leagueIds = null, IEnumerable<long> eventIds = null, long? since = null)
        {
            var request = new RestRequest("/v3/fixtures");

            request.AddQueryParameter("sportId", ((int) sport).ToString());
            request.AddQueryParameter("isLive", onlyLive ? "1" : "0");
            if (since != null) request.AddQueryParameter("since", since.Value.ToString());
            if (leagueIds != null) request.AddQueryParameter("leagueIds", string.Join(",", leagueIds));
            if (eventIds != null) request.AddQueryParameter("eventIds", string.Join(",", eventIds));

            return RequestAsync<PS3838FixturesResponse>(request);
        }

        public Task<PS3838OddsResponse> OddsV3Async(EPS3838Sport sport,
            EPS3838OddsFormat oddsFormat = EPS3838OddsFormat.American, string toCurrencyCode = "USD",
            bool onlyLive = false, IEnumerable<int> leagueIds = null, IEnumerable<long> eventIds = null,
            long? since = null)
        {
            var request = new RestRequest("/v3/odds");

            request.AddQueryParameter("sportId", ((int) sport).ToString());
            request.AddQueryParameter("isLive", onlyLive ? "1" : "0");
            request.AddQueryParameter("oddsFormat", oddsFormat.ToString());
            request.AddQueryParameter("toCurrencyCode", toCurrencyCode);
            if (since != null) request.AddQueryParameter("since", since.Value.ToString());
            if (leagueIds != null) request.AddQueryParameter("leagueIds", string.Join(",", leagueIds));
            if (eventIds != null) request.AddQueryParameter("eventIds", string.Join(",", eventIds));

            return RequestAsync<PS3838OddsResponse>(request);
        }

        public Task<PS3838Line> LineV2Async(EPS3838Sport sport, int leagueId, long eventId, int period, EPS3838OddsFormat oddsFormat, EPS3838BetType betType, EPS3838Team? team = null, EPS3838Side? side = null, double? handicap = null)
        {
            var request = new RestRequest("/v2/line");

            request.AddQueryParameter("sportId", ((int)sport).ToString());
            request.AddQueryParameter("oddsFormat", oddsFormat.ToString());
            request.AddQueryParameter("eventId", eventId.ToString());
            request.AddQueryParameter("leagueId", leagueId.ToString());
            request.AddQueryParameter("periodNumber", period.ToString());
            request.AddQueryParameter("betType", betType.ToString());

            if(handicap != null) request.AddQueryParameter("handicap", handicap.ToString());
            if (team != null) request.AddQueryParameter("team", team.Value.ToString());
            if (side != null) request.AddQueryParameter("side", side.Value.ToString());

            return RequestAsync<PS3838Line>(request);
        }

        public Task<PS3838LeaguesResponse> LeaguesV3Async(EPS3838Sport sport)
        {
            var request = new RestRequest("/v3/leagues");

            request.AddQueryParameter("sportId", ((int)sport).ToString());

            return RequestAsync<PS3838LeaguesResponse>(request);
        }

        public Task<PS383SportsResponse> SportsV3Async()
        {
            return RequestAsync<PS383SportsResponse>(new RestRequest("/v3/sports"));
        }
    }
}
