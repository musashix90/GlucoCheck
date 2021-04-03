using System;
using System.IO;

namespace GlucoCheck.Classes
{
    public static class GCUtility
    {
        #region Functions

        /// <summary>
        /// Writes an array of log entires to an HTML doc for printing
        /// purposes.
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="path">The path where the HTML doc will be saved
        /// to.</param>
        public static void LogToHTMLDoc(LogEntry[] entries, string path)
        {
            //Generate the start of the HTML doc.
            string templatePath = AppDomain.CurrentDomain.BaseDirectory +
                "//Files//PrintLogTemplate.txt";

            string html = File.ReadAllText(templatePath);

            //Add all entries to the HTML table.
            foreach (LogEntry entry in entries)
            {
                html += "\n\n\t\t<tr>" +
                    "\n\t\t\t<td>" + entry.EasyDate + "</td>" +
                    "\n\t\t\t<td>" + entry.EasyTime + "</td>" +
                    "\n\t\t\t<td>" + entry.BSL + "</td>" +
                    "\n\t\t\t<td>" + entry.Carbs + "</td>" +
                    "\n\t\t\t<td>" + entry.InsulinDosed + "</td>" +
                    "\n\t\t</tr>";
            }

            //Add end tags.
            html += "\n\n\t</table>\n\n</html>";

            //Save the HTML file.
            File.WriteAllText(path, html);
        }

        #endregion
    }
}