﻿namespace TheMovie.Models
{
    public class Enums
    {
        public enum MovieCategory
        {            
            NowPlaying,
            Upcoming,
            Popular,
            TopRated
        }

        public static string PathCategoryMovie(MovieCategory category)
        {
            switch (category)
            {                
                case MovieCategory.NowPlaying:
                    return "/movie/now_playing";

                case MovieCategory.Upcoming:
                    return "/movie/upcoming";

                case MovieCategory.Popular:
                    return "/movie/popular";

                case MovieCategory.TopRated:
                    return "/movie/top_rated";                    

                default:
                    return "/movie/upcoming";
            }
        }        
    }
}