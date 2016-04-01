using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WcfFileBinding.Core
{
    public class FileChannel : ChannelBase, IRequestChannel, IChannel, ICommunicationObject
    {
        private readonly FileChannelFactory<IRequestChannel> _channelFactory;
        private readonly Stream _stream;

        public FileChannel(FileChannelFactory<IRequestChannel> channelFactory, Stream stream)
            : base(channelFactory)
        {
            _channelFactory = channelFactory;
            _stream = stream;
        }

        public EndpointAddress RemoteAddress
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Uri Via
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IAsyncResult BeginRequest(Message message, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginRequest(Message message, TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public Message EndRequest(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public Message Request(Message message)
        {
            throw new NotImplementedException();
        }

        public Message Request(Message message, TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        protected override void OnAbort()
        {
            _stream.Flush();
            _stream.Close();
        }

        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override void OnClose(TimeSpan timeout)
        {
            _stream.Flush();
            _stream.Close();
        }

        protected override void OnEndClose(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            
        }

    }
}
