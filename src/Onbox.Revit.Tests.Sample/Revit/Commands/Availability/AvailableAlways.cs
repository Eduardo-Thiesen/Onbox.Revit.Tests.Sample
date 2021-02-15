﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Onbox.Revit.Tests.Sample.Revit.Commands.Availability
{
    /// <summary>
    /// The Command will be available even if no Revit Document is opened
    /// </summary>
    public class AvailableAlways : IExternalCommandAvailability
    {
        public bool IsCommandAvailable(UIApplication applicationData, CategorySet selectedCategories)
        {
            return true;
        }
    }
}