﻿namespace PlenBotLogUploader.PlenyxAPI
{
    public class PlenyxAPIPingTest
    {
        public PlenyxAPIStatus Status { get; set; }
        public PlenyxAPIStatus Error { get; set; }

        public bool IsValid() => (Status?.Code ?? 400) == 200 || (Status?.Code ?? 400) == 201;
    }
}