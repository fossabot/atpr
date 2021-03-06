﻿using System;
using System.IO;

namespace ATPR
{
	/// <summary>
	/// Class that sets a common structure for all the strategies
	/// </summary>
	public abstract class AbstractExecStrategy : ExecStrategy
	{
		public AbstractExecStrategy(Options options)
		{
			this.options = options;
		}

		protected Options options;

		public abstract void Run();

		/// <summary>
		/// Writes the run method result.
		/// </summary>
		/// <param name="result">Result.</param>
		protected void WriteResult(string result)
		{
			if (string.IsNullOrEmpty(options.Output)) Console.Write(result);
			else File.WriteAllText(options.Output, result);
		}

		public abstract bool UsesNER();
		public abstract bool UsesParser();
	}
}
