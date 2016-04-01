using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WcfFileBinding.Core
{
    public class FileChannelFactory<TChannel> : ChannelFactoryBase<TChannel>
    {
        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override TChannel OnCreateChannel(EndpointAddress address, Uri via)
        {
            throw new NotImplementedException();
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}
