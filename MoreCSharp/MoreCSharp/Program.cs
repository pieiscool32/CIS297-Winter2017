using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoreCSharp
{
	class Program
	{
		static void Main( string[] args )
		{
			WriteLine( "abc" );
			string[] letters = { "a", "b", "c", "d" };
			//Print( 2, "a", "b", "c", "d" );
			//Print( 3, letters );

			string oneBigString = File.ReadAllText( "colors.txt" );
			string[] contents = File.ReadAllLines( "fib.txt" );

			int sum = 0;
			foreach( string line in contents )
			{
				int result;
				if ( !Int32.TryParse( line, out result ) )
				{
					WriteLine( $"Failed to convert {line}" );
				}
				sum += result;
			}

			WriteLine( sum );

			WriteLine( "Printing one big string" );
			WriteLine( oneBigString );

			WriteLine( "Printing each string from contents" );

			File.WriteAllText( "Classes.txt", string.Format("CIS297{0}CIS310{0}CIS350{0}CIS375", Environment.NewLine ));

			FileStream fileStream = File.OpenWrite( "binaryContents.openme" );
			BinaryWriter writer = new BinaryWriter( fileStream );

			try
			{
				writer.Write( 1 );
				writer.Write( 1 );
				writer.Write( 2 );
				writer.Write( 3 );
				writer.Write( 5 );
			}
			catch( Exception e)
			{
				WriteLine( e.StackTrace );
			}
			finally
			{
				writer.Close();
			}

		

			FileStream readStream = File.OpenRead( "binaryContents.openme" );
			BinaryReader reader = new BinaryReader( readStream );
			WriteLine( reader.ReadInt32() );
			WriteLine( reader.ReadInt32() );
			WriteLine( reader.ReadInt32() );
			WriteLine( reader.ReadInt32() );
			WriteLine( reader.ReadInt32() );


			Print( 1, contents );


			try
			{
				Triangle triangle = new Triangle();
				triangle.setSides( 3, 4, 5 );
				triangle.setSides( 4, 5, 6 );
			}
			catch(InvalidOperationException e)
			{
				WriteLine( e.StackTrace );
			}
			catch(Exception e)
			{
				WriteLine( e.StackTrace );
			}


			Console.ReadKey();
		}

		public static void Print( int times, params string[] values )
		{
			for ( int time = 0; time < times; time++ )
			{
				foreach ( string value in values )
				{
					WriteLine( value );
				}
			}

		}
	}
}
