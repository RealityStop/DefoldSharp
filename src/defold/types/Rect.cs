namespace types
{
	public class Rect
	{
		public double X, Y;
		public double Width, Height;


		public Rect(double x, double y, double width, double height)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}


		public bool InRect(int targetX, int targetY)
		{
			return X <= targetX && targetX <= (X + Width) &&
			       Y <= targetY && targetY <= (Y + Height);
		}
	}
}