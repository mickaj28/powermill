// **********************************************************************
// *         ? COPYRIGHT 2018 Autodesk, Inc.All Rights Reserved         *
// *                                                                    *
// *  Use of this software is subject to the terms of the Autodesk      *
// *  license agreement provided at the time of installation            *
// *  or download, or which otherwise accompanies this software         *
// *  in either electronic or hard copy form.                           *
// **********************************************************************

namespace Autodesk.ProductInterface.PowerMILL
{
    /// <summary>
    /// Represents a raster area clearance toolpath strategy in PowerMill.
    /// </summary>
    public class PMToolpathRasterAreaClearance : PMToolpath
    {
        #region Constructors

        /// <summary>
        /// Initialises the item.
        /// </summary>
        /// <param name="powerMILL">The base instance to interact with PowerMILL.</param>
        internal PMToolpathRasterAreaClearance(PMAutomation powerMILL) : base(powerMILL)
        {
        }

        /// <summary>
        /// Initialises the item.
        /// </summary>
        /// <param name="powerMILL">The base instance to interact with PowerMILL.</param>
        /// <param name="name">The new instance name.</param>
        internal PMToolpathRasterAreaClearance(PMAutomation powerMILL, string name) : base(powerMILL, name)
        {
        }

        #endregion
    }
}