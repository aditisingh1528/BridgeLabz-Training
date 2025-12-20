using System;

public class avgPcmMarks{
	static void Main(){
		//define marks in all the subjects
		int maths = 94;
		int physics = 95;
		int chemistry = 96;
		//calculate and print the average marks
		int avgMarks = (maths + physics + chemistry)/3;
		Console.WriteLine("Sam;s average mark in PCM: " + avgMarks);
	}
}