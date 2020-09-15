using System;
using System.Runtime.Serialization;

namespace TradingDayAnalyzerDal
{
    [Serializable]
    public class TradingdayDalException : Exception
    {
        public TradingdayDalException()
        {
        }

        public TradingdayDalException(string message) : base(message)
        {
        }

        public TradingdayDalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TradingdayDalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}