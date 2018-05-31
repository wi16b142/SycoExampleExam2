using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace MQHandling
{
    public class MQHandler<T>
    {
        private string mqPath = @"FormatName:direct=os:";
        private string mqPrefix = @".\private$\";
        private string mqName;
        MessageQueue mq;

        public MQHandler(string mqName)
        {
            this.mqName = mqName;

            if (!MessageQueue.Exists(mqPrefix + mqName)) MessageQueue.Create(mqPrefix + mqName);

            mq = new MessageQueue(mqPath + mqPrefix + mqName);
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(T) });
        }

        public void Send(T t)
        {
            mq.Send(t);
        }

        public T Receive()
        {
            return (T)mq.Receive().Body;
        }
    }
}
