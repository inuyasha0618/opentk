﻿using OpenToolkit.NT.Native.User32.Structs;
using UINT = System.UInt32;

namespace OpenToolkit.NT.Native.User32.Enums
{
    /// <summary>
    /// Used in <see cref="User32.RawInput.GetRawInputDeviceInfo(System.IntPtr,
    /// GetRawInputDeviceInfoEnum, byte[], ref UINT)"/> to specify what data to return in the data parameter.
    /// </summary>
    public enum GetRawInputDeviceInfoEnum : UINT
    {
        /// <summary>
        /// data points to the previously parsed data.
        /// </summary>
        PreparsedData = 0x20000005,

        /// <summary>
        /// data points to a string that contains the device name.<para/>
        /// For this command only, the value in dataSize is the character count (not the byte count).
        /// </summary>
        DeviceName = 0x20000007,

        /// <summary>
        /// data points to an <see cref="RawInputDeviceInfo"/> structure.
        /// </summary>
        DeviceInfo = 0x2000000b
    }
}