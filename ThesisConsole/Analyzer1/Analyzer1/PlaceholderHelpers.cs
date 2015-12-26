﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Analyzer1
{
    internal static class PlaceholderHelpers
    {
        /// <summary>
        ///     Removes all curly braces and formatting definitions from the placeholder
        /// </summary>
        /// <param name="input">The placeholder entry to parse.</param>
        /// <returns>Returns the placeholder index.</returns>
        internal static string GetPlaceholderIndex(string input)
        {
            var temp = input.Trim('{', '}');
            var colonIndex = temp.IndexOf(':');
            if (colonIndex > 0)
            {
                return temp.Remove(colonIndex);
            }

            return temp;
        }

        /// <summary>
        ///     Get all elements in a string that are enclosed by an uneven amount of curly brackets (to account for escaped
        ///     brackets).
        ///     The result will be elements that are either plain integers or integers with a format appended to it, delimited by a
        ///     colon.
        /// </summary>
        /// <param name="input">The format string with placeholders.</param>
        /// <returns>Returns a collection of matches according to the regex.</returns>
        internal static MatchCollection GetPlaceholders(string input)
        {
            // This regex uses a named group so we can easily access the actual value
            return Regex.Matches(input, @"(?<!\{)\{(?:\{\{)*((?<index>\d+)(?::.*?)?)\}(?:\}\})*(?!\})");
        }

        /// <summary>
        ///     Returns all elements from the input, split on the placeholders.
        ///     This method is useful if you want to make use of the rest of the string as well.
        /// </summary>
        internal static string[] GetPlaceholdersSplit(string input)
        {
            return Regex.Split(input, @"(?<!\{)\{(?:\{\{)*(\d+(?::.*?)?)\}(?:\}\})*(?!\})");
        }
    }
}
