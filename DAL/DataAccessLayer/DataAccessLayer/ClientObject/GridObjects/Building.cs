﻿using System;

namespace ServerForTheLogic.ClientObject.Building
{
    /// <summary>
    /// Building Class
    /// Team: DB
    /// Building class that contain general fields for all building types.
    /// <para> Author: Bill </para>
    /// Date: 2017-11-12 
    /// </summary>
    public class Building : GridObject
    {
        /// <summary>
        /// A building constructor. Calls base GridObject's constructor
        /// </summary>
        /// <param name="guid">The Guid of the building</param>
        /// <param name="xPoint">The X coordinate of the building</param>
        /// <param name="yPoint">The Y coordinate of the building</param>
        /// <param name="rating">The rating of the building</param>
        /// <param name="isTall">Boolean if the building is tall or not</param>
        /// <param name="capacity">The capacity of the building</param>
        public Building(Guid guid, int xPoint, int yPoint, int rating, bool isTall, int capacity) : base(guid, xPoint, yPoint)
        {
            Rating = rating;
            IsTall = isTall;
            Capacity = capacity;
        }

        /// <summary>
        /// Rating is an int between 1 - 3
        /// </summary>            
        public int Rating { get; set; }

        /// <summary>
        /// is this a tall building? This is used for rendering graphics model
        /// </summary>
        public Boolean IsTall { get; set; }

        /// <summary>
        /// max number of person allowed in the building
        /// </summary>
        public int Capacity { get; set; }
    }
}
