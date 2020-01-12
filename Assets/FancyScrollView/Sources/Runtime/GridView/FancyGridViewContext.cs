﻿/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2019 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using System;
using UnityEngine;

namespace FancyScrollView
{
    /// <summary>
    /// <see cref="FancyGridView{TItemData, TContext}"/> のコンテキスト基底クラス.
    /// </summary>
    public class FancyGridViewContext : IFancyGridViewContext
    {
        Func<(float ScrollSize, float ReuseMargin)> IFancyScrollRectContext.CalculateScrollSize { get; set; }
        GameObject IFancyCellGroupContext.CellTemplate { get; set; }
        ScrollDirection IFancyGridViewContext.ScrollDirection { get; set; }
        Func<int> IFancyCellGroupContext.GetGroupCount { get; set; }
        Func<float> IFancyGridViewContext.GetStartAxisSpacing { get; set; }
        Func<float> IFancyGridViewContext.GetCellSize { get; set; }
    }
}