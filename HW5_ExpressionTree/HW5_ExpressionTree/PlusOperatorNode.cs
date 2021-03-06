// <copyright file="PlusOperatorNode.cs" company="Koji Natsuhara (ID: 11666900)">
// Copyright (c) Koji Natsuhara (ID: 11666900). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CptS321
{
    /// <summary>
    /// The addition operator node.
    /// </summary>
    public class PlusOperatorNode : OperatorNode
    {
        /// <summary>
        /// Gets the character operator associated with this node.
        /// </summary>
        public static char Operator => '+';

        /// <summary>
        /// Gets the precedence level in the order of operations.
        /// </summary>
        public static ushort Precedence => 14;

        /// <summary>
        /// Gets the associativity with operations of the same precedence.
        /// </summary>
        public static Associative Associativity => Associative.Left;

        /// <summary>
        /// This will add the left and right nodes and return the value.
        /// </summary>
        /// <returns>Value as a double.</returns>
        public override double Evaluate()
        {
            return this.Left.Evaluate() + this.Right.Evaluate();
        }
    }
}
