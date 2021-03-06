﻿/*
 * Media Extractor is an application to preview and extract packed media in Microsoft Office files (e.g. Word, PowerPoint or Excel documents)
 * Copyright Raphael Stoeckli © 2018
 * This program is licensed under the MIT License.
 * You find a copy of the license in project folder or on: http://opensource.org/licenses/MIT
 */

namespace MediaExtractor
{
    /// <summary>
    /// Class to represent a ListView row / entry
    /// </summary>
    public class ListViewItem
    {
        /// <summary>
        /// Enum to define the coarse file type of the entry
        /// </summary>
        public enum FileType
        {
            /// <summary>Entry is an image</summary>
            Image,
            /// <summary>Entry is an XML file</summary>
            Xml,
            /// <summary>Entry is a text file</summary>
            Text,
            /// <summary>Entry is not an image</summary>
            Other,
            /// <summary>Entry no file at all / error</summary>
            None,
        }

        /// <summary>
        /// File name of the entry
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// File extension of the entry
        /// </summary>
        public string FileExtension { get; set; }

        /// <summary>
        /// Relative path of the file
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Coarse file type of the entry
        /// </summary>
        public FileType Type { get; set; }
        /// <summary>
        /// Reference to the ExtractorItem of the entry
        /// </summary>
        public ExtractorItem FileReference { get; set; }

        /// <summary>
        /// Method to determine the type of the item
        /// </summary>
        public void SetType()
        {
            if (FileReference.IsXml)
            {
                Type = FileType.Xml;
            }
            else if (FileReference.IsImage)
            {
                Type = FileType.Image;
            }
            else if (FileReference.IsText)
            {
                Type = FileType.Text;
            }
            else
            {
                Type = FileType.Other;
            }
        }

    }
}
