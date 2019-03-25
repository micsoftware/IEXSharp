﻿namespace IEX.V2.Model.Account
{
    /// <summary>
    /// <see cref="https://iexcloud.io/docs/api/#metadata"/>
    /// </summary>
    public class MetadataResponse
    {
        public bool payAsYouGoEnabled { get; set; }
        public long effectiveDate { get; set; }
        public long endDateEffective { get; set; }
        public string subscriptionTermType { get; set; }
        public string tierName { get; set; }
        public int messageLimit { get; set; }
        public int messagesUsed { get; set; }
    }
}