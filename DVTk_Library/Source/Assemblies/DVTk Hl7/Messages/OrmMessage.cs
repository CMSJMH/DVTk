// ------------------------------------------------------
// DVTk - The Healthcare Validation Toolkit (www.dvtk.org)
// Copyright ? 2009 DVTk
// ------------------------------------------------------
// This file is part of DVTk.
//
// DVTk is free software; you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License as published by the Free Software Foundation; either version 3.0
// of the License, or (at your option) any later version. 
// 
// DVTk is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even
// the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser
// General Public License for more details. 
// 
// You should have received a copy of the GNU Lesser General Public License along with this
// library; if not, see <http://www.gnu.org/licenses/>

using System;
using Dvtk.Hl7;

namespace Dvtk.Hl7.Messages
{
	/// <summary>
	/// ORM Message class
	/// </summary>
	public class OrmMessage : Hl7Message
	{
        /// <summary>
		/// Class constructor - ORM
		/// </summary>
        public OrmMessage() : base() { }

		/// <summary>
		/// Class constructor
		/// </summary>
		/// <param name="messageSubType">ORM Message Sub Type.</param>
		public OrmMessage(System.String messageSubType) : base("ORM", messageSubType)
		{
			Hl7Segment segment = new Hl7Segment(1, Hl7SegmentEnum.PID);
			Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(2, Hl7SegmentEnum.PD1);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(3, Hl7SegmentEnum.PV1);
			Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(4, Hl7SegmentEnum.PV2);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(5, Hl7SegmentEnum.IN1);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(6, Hl7SegmentEnum.IN2);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(7, Hl7SegmentEnum.IN3);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(8, Hl7SegmentEnum.GT1);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(9, Hl7SegmentEnum.AL1);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(10, Hl7SegmentEnum.ORC);
			Segments.Add(segment.SegmentId.Id, segment);
			segment = new Hl7Segment(11, Hl7SegmentEnum.OBR);
			Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(12, Hl7SegmentEnum.NTE);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(13, Hl7SegmentEnum.DG1);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(14, Hl7SegmentEnum.OBX);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(15, Hl7SegmentEnum.CTI);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(16, Hl7SegmentEnum.BLG);
            Segments.Add(segment.SegmentId.Id, segment);
            segment = new Hl7Segment(17, Hl7SegmentEnum.ZDS);
			Segments.Add(segment.SegmentId.Id, segment);
		}

        #region Segment Properties
        /// <summary>
		/// Property - PID Segment
		/// </summary>
		public Hl7Segment PID
		{
			get
			{
				Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.PID);
				return (Hl7Segment)Segments[segmentId.Id];
			}
		}

        /// <summary>
        /// Property - PD1 Segment
        /// </summary>
        public Hl7Segment PD1
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.PD1);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
		/// Property - PV1 Segment
		/// </summary>
		public Hl7Segment PV1
		{
			get
			{
				Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.PV1);
				return (Hl7Segment)Segments[segmentId.Id];
			}
		}

        /// <summary>
        /// Property - PV2 Segment
        /// </summary>
        public Hl7Segment PV2
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.PV2);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - IN1 Segment
        /// </summary>
        public Hl7Segment IN1
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.IN1);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - IN2 Segment
        /// </summary>
        public Hl7Segment IN2
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.IN2);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - IN3 Segment
        /// </summary>
        public Hl7Segment IN3
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.IN3);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - GT1 Segment
        /// </summary>
        public Hl7Segment GT1
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.GT1);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - AL1 Segment
        /// </summary>
        public Hl7Segment AL1
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.AL1);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
		/// Property - ORC Segment
		/// </summary>
		public Hl7Segment ORC
		{
			get
			{
				Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.ORC);
				return (Hl7Segment)Segments[segmentId.Id];
			}
		}

		/// <summary>
		/// Property - OBR Segment
		/// </summary>
		public Hl7Segment OBR
		{
			get
			{
				Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.OBR);
				return (Hl7Segment)Segments[segmentId.Id];
			}
		}

        /// <summary>
        /// Property - NTE Segment
        /// </summary>
        public Hl7Segment NTE
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.NTE);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - DG1 Segment
        /// </summary>
        public Hl7Segment DG1
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.DG1);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - OBX Segment
        /// </summary>
        public Hl7Segment OBX
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.OBX);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - CTI Segment
        /// </summary>
        public Hl7Segment CTI
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.CTI);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
        /// Property - BLG Segment
        /// </summary>
        public Hl7Segment BLG
        {
            get
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.BLG);
                return (Hl7Segment)Segments[segmentId.Id];
            }
        }

        /// <summary>
		/// Property - ZDS Segment
		/// </summary>
		public Hl7Segment ZDS
		{
			get
			{
				Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.ZDS);
				return (Hl7Segment)Segments[segmentId.Id];
			}
		}

        /// <summary>
        /// Set the OBR value given at the segment/field index.
        /// </summary>
        /// <param name="segmentIndex">OBR Segment Index.</param>
        /// <param name="fieldIndex">OBR Field Index (within Segment).</param>
        /// <param name="stringValue">Value to set.</param>
        public void obrSeg(int segmentIndex, int fieldIndex, System.String stringValue)
        {
            Hl7Segment segment = null;
            if (segmentIndex > 0)
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.OBR, segmentIndex);
                segment = (Hl7Segment)Segments[segmentId.Id];
                if (segment == null)
                {
                    segment = new Hl7Segment(0, Hl7SegmentEnum.OBR);
                    segment.SegmentId.SegmentIndex = segmentIndex;
                    AddSegment(segment);
                }
            }
            segment[fieldIndex] = stringValue;
        }

        /// <summary>
        /// Set the NTE value given at the segment/field index.
        /// </summary>
        /// <param name="segmentIndex">NTE Segment Index.</param>
        /// <param name="fieldIndex">NTE Field Index (within Segment).</param>
        /// <param name="stringValue">Value to set.</param>
        public void nteSeg(int segmentIndex, int fieldIndex, System.String stringValue)
        {
            Hl7Segment segment = null;
            if (segmentIndex > 0)
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.NTE, segmentIndex);
                segment = (Hl7Segment)Segments[segmentId.Id];
                if (segment == null)
                {
                    segment = new Hl7Segment(0, Hl7SegmentEnum.NTE);
                    segment.SegmentId.SegmentIndex = segmentIndex;
                    AddSegment(segment);
                }
            }
            segment[fieldIndex] = stringValue;
        }

        /// <summary>
        /// Set the OBX value given at the segment/field index.
        /// </summary>
        /// <param name="segmentIndex">OBX Segment Index.</param>
        /// <param name="fieldIndex">OBX Field Index (within Segment).</param>
        /// <param name="stringValue">Value to set.</param>
        public void obxSeg(int segmentIndex, int fieldIndex, System.String stringValue)
        {
            Hl7Segment segment = null;
            if (segmentIndex > 0)
            {
                Hl7SegmentId segmentId = new Hl7SegmentId(Hl7SegmentEnum.OBX, segmentIndex);
                segment = (Hl7Segment)Segments[segmentId.Id];
                if (segment == null)
                {
                    segment = new Hl7Segment(0, Hl7SegmentEnum.OBX);
                    segment.SegmentId.SegmentIndex = segmentIndex;
                    AddSegment(segment);
                }
            }
            segment[fieldIndex] = stringValue;
        }
        #endregion Segment Properties
    }
}
