using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
	class GasMeter
	{
		public int MeterID { get; set; }
		public int VolumeUsed { get; set; }
		public bool HasBeenServiced { get; set; }
		public int AccountOwnerID { get; set; }
	}
}
