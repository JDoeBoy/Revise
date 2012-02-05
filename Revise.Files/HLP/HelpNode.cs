﻿#region License

/**
 * Copyright (C) 2012 Jack Wakefield
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

#endregion

using System.Collections.Generic;

namespace Revise.Files.HLP {
    /// <summary>
    /// Represents a help node.
    /// </summary>
    public class HelpNode {
        #region Properties

        /// <summary>
        /// Gets or sets the node name.
        /// </summary>
        public string Name {
            get;
            set;
        }

        /// <summary>
        /// Gets the child nodes.
        /// </summary>
        public List<HelpNode> Children {
            get;
            private set;
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="HelpNode"/> class.
        /// </summary>
        public HelpNode() {
            Name = string.Empty;
            Children = new List<HelpNode>();
        }
    }
}