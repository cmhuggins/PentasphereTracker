using System;

namespace PentasphereTracker.Helpers {
	/// <summary>Class <c>PolarCoord</c>
	/// maps the 3D object's position by axis
	/// </summary>
	public struct PolarCoord {
		// Hold the axis of which this PolarCoord represents
		public Axis GetAxis { get; }
		// Hold the actual polar coordinate for use
		public double Degree { get; }
		
		/// <summary>Constructor <c>PolarCoord</c>
		/// creates a holder for the polar coordinate for use elsewhere
		/// </summary>
		/// <param name="axis">The axis of which this polar coordinate exists</param>
		public PolarCoord(Axis axis) {
			GetAxis = axis;

			var random = new Random();
			Degree = random.NextDouble();
			Degree *= random.Next(-180, 180);
		}
	}
}