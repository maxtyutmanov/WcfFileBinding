using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WcfFileBinding.Core
{
    public class FileTransportBindingElement : TransportBindingElement
    {
        private readonly string _exchangeFilePath;

        public FileTransportBindingElement(string exchangeFilePath)
        {
            
        }

        public override string Scheme
        {
            get
            {
                return "fb";
            }
        }

        public override BindingElement Clone()
        {
            return new FileTransportBindingElement(_exchangeFilePath);
        }
    }
}
