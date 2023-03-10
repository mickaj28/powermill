// **********************************************************************
// *         ? COPYRIGHT 2018 Autodesk, Inc.All Rights Reserved         *
// *                                                                    *
// *  Use of this software is subject to the terms of the Autodesk      *
// *  license agreement provided at the time of installation            *
// *  or download, or which otherwise accompanies this software         *
// *  in either electronic or hard copy form.                           *
// **********************************************************************

using System;

namespace Autodesk.ProductInterface.PowerSHAPE
{
    /// <summary>
    /// Captures a Surface Lateral object in PowerSHAPE
    /// </summary>
    public class PSLateral : PSSurfaceCurve
    {
        #region " Fields "

        #endregion

        #region " Properties "

        /// <summary>
        /// Gets identifier of the Lateral
        /// </summary>
        internal override string Identifier
        {
            get { return "SURFACE['" + _surface.Name + "'].LATERAL"; }
        }

        /// <summary>
        /// Gets short type of the Lateral
        /// </summary>
        internal override string ShortType
        {
            get { return "LAT"; }
        }

        #endregion

        #region " Constructors "

        /// <summary>
        /// Connects to PowerSHAPE and a specific entity using its name
        /// </summary>
        internal PSLateral(PSAutomation powerSHAPE, string name, PSSurface surface) : base(powerSHAPE, surface)
        {
            _powerSHAPE = powerSHAPE;
            _name = name;
            _surface = surface;

            _id = _powerSHAPE.ReadIntValue(Identifier + "[" + name + "].ID");
            _internalId = Guid.NewGuid();
        }

        #endregion

        #region " Operations "

        /// <summary>
        /// Deletes the Surface Lateral from PowerSHAPE
        /// </summary>
        public override void Delete()
        {
            // Delete the surface curve
            base.Delete();

            // Update all other longitudinal names and IDs to match their changes in PowerSHAPE
            for (int i = int.Parse(_name + 1); i <= _surface.Laterals.Count - 1; i++)
            {
                _surface.Laterals[i]._id = i;
                _surface.Laterals[i]._name = i.ToString();
            }
        }

        #endregion
    }
}