using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WcfFileBinding.Core
{
    public class FileBinding : Binding
    {
        private readonly string _exchangeFilePath;

        public FileBinding(string exchangeFilePath)
        {
            this._exchangeFilePath = exchangeFilePath;
        }

        public override string Scheme
        {
            get
            {
                return "fb";
            }
        }

        public override BindingElementCollection CreateBindingElements()
        {
            return new BindingElementCollection(new BindingElement[]
            {
                new TextMessageEncodingBindingElement(),
                new FileTransportBindingElement(_exchangeFilePath)
            });
        }
    }
}
