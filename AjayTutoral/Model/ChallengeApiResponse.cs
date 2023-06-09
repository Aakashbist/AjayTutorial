﻿namespace AjayTutoral.Model
{
    public class ChallengeApiResponse
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        //{{ "match":{},"match":{}]}
        public class Match
        {
            public int id { get; set; }
            public int tournament_id { get; set; }
            public string state { get; set; }
            public int? player1_id { get; set; }
            public int? player2_id { get; set; }
            public int? player1_prereq_match_id { get; set; }
            public int? player2_prereq_match_id { get; set; }
            public bool player1_is_prereq_match_loser { get; set; }
            public bool player2_is_prereq_match_loser { get; set; }
            public int? winner_id { get; set; }
            public int? loser_id { get; set; }
            public DateTime? started_at { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string identifier { get; set; }
            public bool has_attachment { get; set; }
            public int round { get; set; }
            public object player1_votes { get; set; }
            public object player2_votes { get; set; }
            public int? group_id { get; set; }
            public object attachment_count { get; set; }
            public object scheduled_time { get; set; }
            public object location { get; set; }
            public DateTime? underway_at { get; set; }
            public bool? optional { get; set; }
            public string rushb_id { get; set; }
            public DateTime? completed_at { get; set; }
            public int suggested_play_order { get; set; }
            public bool? forfeited { get; set; }
            public object open_graph_image_file_name { get; set; }
            public object open_graph_image_content_type { get; set; }
            public object open_graph_image_file_size { get; set; }
            public string prerequisite_match_ids_csv { get; set; }
            public string scores_csv { get; set; }
        }

        public class Root
        {
            public Match match { get; set; }
        }


    }
}
