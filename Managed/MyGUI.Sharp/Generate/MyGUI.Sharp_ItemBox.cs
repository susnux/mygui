﻿/*!
	@file
	@author		Generate utility by Albert Semenov
	@date		01/2009
	@module
*/

using System;
using System.Runtime.InteropServices;

namespace MyGUI.Sharp
{

    public class ItemBox : DDContainer
    {

        #region ItemBox

        public ItemBox()
            : base()
        {
        }

        public ItemBox(BaseWidget _parent, IntPtr _widget)
            : base(_parent, _widget)
        {
        }

        public ItemBox(IntPtr _parent, WidgetStyle _style, string _skin, IntCoord _coord, Align _align, string _layer, string _name)
            : base(_parent, _style, _skin, _coord, _align, _layer, _name)
        {
        }

        protected override string GetWidgetType() { return "ItemBox"; }

		#endregion
	
		
		//InsertPoint
		
    }

}
