﻿namespace TrackerLibrary
{
    public class SqlConnector: IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}