﻿namespace recyclecollection.Models
{
    public class Datacollection
    {
        public int collection_id  { get; set; }

        public DateTime? date { get; set; }

        public string category { get; set; }

        public string subcategory { get; set; }

        public int weight { get; set; }

        public char recycle_type { get; set; }
    }
}
