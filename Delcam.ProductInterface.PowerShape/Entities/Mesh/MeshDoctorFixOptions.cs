// **********************************************************************
// *         ? COPYRIGHT 2018 Autodesk, Inc.All Rights Reserved         *
// *                                                                    *
// *  Use of this software is subject to the terms of the Autodesk      *
// *  license agreement provided at the time of installation            *
// *  or download, or which otherwise accompanies this software         *
// *  in either electronic or hard copy form.                           *
// **********************************************************************

namespace Autodesk.ProductInterface.PowerSHAPE
{
    /// <summary>
    /// Options for MeshDoctor operation that will be performed.
    /// </summary>
    public enum MeshDoctorFixOptions
    {
        All,
        RestrictBadConnection,
        RestrictBoundary,
        RestrictAspect,
        RestrictSmall,
        RestrictIntersect,
        RestrictOverlap,
        Status
    }
}