﻿using System;

namespace Minion.Ioc.Aspects
{
	public class AspectEventContext
	{
		public object CallerReference { get; set; }
		public Type CallerType { get; set; }
		public string MemberName { get; set; }
	}
}
