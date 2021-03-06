﻿// Copyright 2014 Josh Close
// This file is a part of Pjax.Mvc and is licensed under the MS-PL
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html
namespace Pjax.Mvc5
{
	public interface IPjax
	{
		bool IsPjaxRequest { get; set; }

		string PjaxVersion { get; set; }
	}
}
