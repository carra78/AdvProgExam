using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Exam2
{
	class MySettings : ApplicationSettingsBase
	{
		[ApplicationScopedSetting()]
		//[DefaultSettingValue("^CONF_(ARTS|BUSINESS|LAW)$")]
		public string ConfID
		{
			get { return this.ConfID; }
			set { this.ConfID = "^CONF_(ARTS | BUSINESS | LAW)$"; }


		}

	}
}
