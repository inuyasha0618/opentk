//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Used in GL.Arb.BlendEquation, GL.BlendEquation and 2 other functions
    /// </summary>
    public enum BlendEquationMode
    {
        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = 0x8006,

        /// <summary>
        /// Original was GL_MIN = 0x8007
        /// </summary>
        Min = 0x8007,

        /// <summary>
        /// Original was GL_MAX = 0x8008
        /// </summary>
        Max = 0x8008,

        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = 0x800a,

        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = 0x800b
    }
}