using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Server
{
	internal class Program
	{
		[ServiceContract]
		public interface IMessageService
		{
			string[] GetMessages();
		}
		static void Main(string[] args)
		{
		}
	}
}
