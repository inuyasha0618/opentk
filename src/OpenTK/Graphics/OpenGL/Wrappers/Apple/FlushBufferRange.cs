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
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "FlushBufferRange" in the extension "Apple".
        /// </summary>
        public static partial class Apple
        {
            /// <summary>
            /// [requires: APPLE_flush_buffer_range]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "APPLE_flush_buffer_range", Version = "", EntryPoint = "glBufferParameteriAPPLE")]
            public static void BufferParameter(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferParameterApple pname, int param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: APPLE_flush_buffer_range]
            /// Indicate modifications to a range of a mapped buffer
            /// </summary>
            /// <param name="target">
            /// Specifies the target of the flush operation. target must be ArrayBuffer, CopyReadBuffer, CopyWriteBuffer, DispatchIndirectBuffer, DrawIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
            /// </param>
            /// <param name="offset">
            /// Specifies the start of the buffer subrange, in basic machine units.
            /// </param>
            /// <param name="size">
            /// Specifies the length of the buffer subrange, in basic machine units.
            /// </param>
            [AutoGenerated(Category = "APPLE_flush_buffer_range", Version = "", EntryPoint = "glFlushMappedBufferRangeAPPLE")]
            public static void FlushMappedBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr offset, int size)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: APPLE_flush_buffer_range]
            /// Indicate modifications to a range of a mapped buffer
            /// </summary>
            /// <param name="target">
            /// Specifies the target of the flush operation. target must be ArrayBuffer, CopyReadBuffer, CopyWriteBuffer, DispatchIndirectBuffer, DrawIndirectBuffer, ElementArrayBuffer, PixelPackBuffer, PixelUnpackBuffer, QueryBuffer, ShaderStorageBuffer, TextureBuffer, TransformFeedbackBuffer, or UniformBuffer.
            /// </param>
            /// <param name="offset">
            /// Specifies the start of the buffer subrange, in basic machine units.
            /// </param>
            /// <param name="size">
            /// Specifies the length of the buffer subrange, in basic machine units.
            /// </param>
            [AutoGenerated(Category = "APPLE_flush_buffer_range", Version = "", EntryPoint = "glFlushMappedBufferRangeAPPLE")]
            public static void FlushMappedBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr offset, IntPtr size)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(139)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBufferParameteriAPPLE(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferParameterApple pname, int param);

            [Slot(584)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFlushMappedBufferRangeAPPLE(OpenTK.Graphics.OpenGL.BufferTarget target, IntPtr offset, IntPtr size);
        }
    }
}