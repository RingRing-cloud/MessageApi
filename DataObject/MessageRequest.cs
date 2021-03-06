﻿namespace RingRing
{
    public class MessageRequest
    {
        /// <summary>
        /// Gateway Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Msisdn separated by a coma
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Message, cannot be longer than 758 chars
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Number (or shortcode)
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// SenderId
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// TimeValidity is an optional datetime to indicate the validity. per default it is now + 72 hours
        /// Format example: 30-06-2017 10:00
        /// </summary>
        public string TimeValidity { get; set; }
        
        /// <summary>
        /// TimeScheduled is a date in the future. It's optional. Default is current date and time.
        /// Format example: 28-06-2017 15:00
        /// </summary>
        public string TimeScheduled { get; set; }
        
        /// <summary>
        /// Reference is optional. It's your reference.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Replace message. True or False or 1 or 0
        /// </summary>
        public string ReplaceIfPresent { get; set; }

        /// <summary>
        /// Status of Message (DLR)
        /// </summary>
        public string StatusUrl { get; set; }

        /// <summary>
        /// Method of status (DLR). POST or GET
        /// </summary>
        public string StatusMethod { get; set; }

        /// <summary>
        /// Format Xml or Json
        /// </summary>
        public string StatusFormat { get; set; }

        public SmsEncodings MessageEncoding { get; set; }
    }
    
}
