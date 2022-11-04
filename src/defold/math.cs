using System;
using support;
using types;

/// <summary>
/// Lua math standard library
/// 
/// </summary>
public static class Math
{
	#region Defold API

		
	/// <summary>
	/// @CSharpLua.Template = "math.abs({0})"
	/// </summary>
	public static extern double abs(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.acos({0})"
	/// </summary>
	public static extern double acos(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.asin({0})"
	/// </summary>
	public static extern double asin(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.atan({0})"
	/// </summary>
	public static extern double atan(double x);
	
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.atan2({0},{1})"
	/// </summary>
	public static extern double atan2(double x, double y);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.ceil({0})"
	/// </summary>
	public static extern double ceil(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.cos({0})"
	/// </summary>
	public static extern double cos(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.cosh({0})"
	/// </summary>
	public static extern double cosh(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.deg({0})"
	/// </summary>
	public static extern double deg(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.exp({0})"
	/// </summary>
	public static extern double exp(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.floor({0})"
	/// </summary>
	public static extern double floor(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.fmod({0},{1})"
	/// </summary>
	public static extern double fmod(double x, double y);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.frexp({0})"
	/// </summary>
	public static extern double frexp(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.ldexp({0},{1})"
	/// </summary>
	public static extern double ldexp(double x, double y);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.log({0})"
	/// </summary>
	public static extern double log(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.log10({0})"
	/// </summary>
	public static extern double log10(double x);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1})"
	/// </summary>
	public static extern double max(double x1, double x2);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1},{2})"
	/// </summary>
	public static extern double max(double x1, double x2, double x3);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1},{2},{3})"
	/// </summary>
	public static extern double max(double x1, double x2, double x3, double x4);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1},{2},{3},{4})"
	/// </summary>
	public static extern double max(double x1, double x2, double x3, double x4, double x5);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1},{2},{3},{4},{5})"
	/// </summary>
	public static extern double max(double x1, double x2, double x3, double x4, double x5, double x6);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1},{2},{3},{4},{5},{6})"
	/// </summary>
	public static extern double max(double x1, double x2, double x3, double x4, double x5, double x6, double x7);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1},{2},{3},{4},{5},{6},{7})"
	/// </summary>
	public static extern double max(double x1, double x2, double x3, double x4, double x5, double x6, double x7, double x8);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1},{2},{3},{4},{5},{6},{7},{8})"
	/// </summary>
	public static extern double max(double x1, double x2, double x3, double x4, double x5, double x6, double x7, double x8, double x9);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.max({0},{1},{2},{3},{4},{5},{6},{7},{8},{9})"
	/// </summary>
	public static extern double max(double x1, double x2, double x3, double x4, double x5, double x6, double x7, double x8, double x9, double x10);


	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1})"
	/// </summary>
	public static extern double min(double x1, double x2);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1},{2})"
	/// </summary>
	public static extern double min(double x1, double x2, double x3);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1},{2},{3})"
	/// </summary>
	public static extern double min(double x1, double x2, double x3, double x4);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1},{2},{3},{4})"
	/// </summary>
	public static extern double min(double x1, double x2, double x3, double x4, double x5);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1},{2},{3},{4},{5})"
	/// </summary>
	public static extern double min(double x1, double x2, double x3, double x4, double x5, double x6);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1},{2},{3},{4},{5},{6})"
	/// </summary>
	public static extern double min(double x1, double x2, double x3, double x4, double x5, double x6, double x7);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1},{2},{3},{4},{5},{6},{7})"
	/// </summary>
	public static extern double min(double x1, double x2, double x3, double x4, double x5, double x6, double x7, double x8);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1},{2},{3},{4},{5},{6},{7},{8})"
	/// </summary>
	public static extern double min(double x1, double x2, double x3, double x4, double x5, double x6, double x7, double x8, double x9);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.min({0},{1},{2},{3},{4},{5},{6},{7},{8},{9})"
	/// </summary>
	public static extern double min(double x1, double x2, double x3, double x4, double x5, double x6, double x7, double x8, double x9, double x10);


	/// <summary>
	/// @CSharpLua.Template = "math.modf({0})"
	/// </summary>
	public static extern double modf(double x1);


	/// <summary>
	/// @CSharpLua.Template = "math.pow({0},{1})"
	/// </summary>
	public static extern double pow(double x, double y);


	/// <summary>
	/// @CSharpLua.Template = "math.rad({0})"
	/// </summary>
	public static extern double rad(double x);
	
	
	/// <summary>
	/// This function is an interface to the simple
	/// pseudo-random generator function rand provided by ANSI C.
	/// (No guarantees can be given for its statistical properties.)
	/// When called without arguments,
	/// returns a uniform pseudo-random real number
	/// in the range [0,1).
	/// When called with an integer number m,
	/// math.random returns
	/// a uniform pseudo-random integer in the range [1, m].
	/// When called with two integer numbers m and n,
	/// math.random returns a uniform pseudo-random
	/// integer in the range [m, n].
	/// 
	/// @CSharpLua.Template = "math.random()"
	/// </summary>
	public static extern float random();

	
	/// <summary>
	/// @CSharpLua.Template = "math.random({0})"
	/// </summary>
	public static extern float random(double m);

	
	/// <summary>
	/// @CSharpLua.Template = "math.random({0}, {1})"
	/// </summary>
	public static extern float random(double m, double n);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.random({0})"
	/// </summary>
	public static extern int random(int m);

	
	/// <summary>
	/// @CSharpLua.Template = "math.random({0}, {1})"
	/// </summary>
	public static extern int random(int m, int n);

	
	/// <summary>
	/// @CSharpLua.Template = "math.randomseed({0})"
	/// </summary>
	public static extern void randomseed(double x);
	

	/// <summary>
	/// @CSharpLua.Template = "math.sin({0})"
	/// </summary>
	public static extern double sin(double x);


	/// <summary>
	/// @CSharpLua.Template = "math.sinh({0})"
	/// </summary>
	public static extern double sinh(double x);


	/// <summary>
	/// @CSharpLua.Template = "math.sqrt({0})"
	/// </summary>
	public static extern double sqrt(double x);


	/// <summary>
	/// @CSharpLua.Template = "math.tan({0})"
	/// </summary>
	public static extern double tan(double x);


	/// <summary>
	/// @CSharpLua.Template = "math.tan({0})"
	/// </summary>
	public static extern double tanh(double x);


	
	/// <summary>
	/// @CSharpLua.Template = "math.huge"
	/// </summary>
	private extern static double GetHuge();
	public readonly static double Huge = GetHuge();
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.pi"
	/// </summary>
	private extern static double GetPI();
	public static double PI { get; } = GetPI();

	
	/// <summary>
	/// @CSharpLua.Template = "(2*math.pi)"
	/// </summary>
	private extern static double GetTau();


	/// <summary>
	/// The mathematically superior and far more intuitive constant.  2 x PI.   So, a quarter circle is TAU/4, half a circle is TAU/2, etc.  
	/// </summary>
	public static double TAU { get; } = GetTau();


	#endregion Defold API



}
