namespace modulkpl9_1302213003
{
    public class Movie
    {
        public String Title { get; set; }
        public String Director { get; set; }
        public String Stars1 { get; set; }
        public String Stars2 { get; set; }
        public String Stars3 { get; set; }
        public String Stars4 { get; set; }

        public String Description { get; set; }

        public Movie(String title, String director, String stars1, String stars2, String stars3, String stars4, String description)
        {
            this.Title = title;
            this.Director = director;
            this.Stars1 = stars1;
            this.Stars2 = stars2;
            this.Stars3 = stars3;
            this.Stars4 = stars4;
            this.Description = description;
        }
    }
}
