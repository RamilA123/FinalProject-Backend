﻿namespace OrganiDb.Models
{
    public class Customer : BaseEntity
    {
        public string Image { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
