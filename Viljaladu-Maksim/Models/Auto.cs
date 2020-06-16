using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Viljaladu.Models
{
	public class Auto
	{
		public int id { get; set; }
		public string autoNr { get; set; }
		[Range(0, 500)]
		public double sisenemisMass { get; set; }
		[Range(0, 500)]
		public double lahkumisMass { get; set; }
	}
}