﻿using System;
using System.Collections.Generic;
using System.Text;
using HASSAgent.Shared.Enums;
using HASSAgent.Shared.Functions;
using HASSAgent.Shared.Models.Config;

namespace HASSAgent.Shared.Extensions
{
    /// <summary>
    /// Extensions for HASS.Agent sensor objects
    /// </summary>
    public static class SensorExtensions
    {
        /// <summary>
        /// Returns the name of the sensortype
        /// </summary>
        /// <param name="sensorType"></param>
        /// <returns></returns>
        public static string GetSensorName(this SensorType sensorType)
        {
            var sensorName = sensorType.ToString().ToLower().Replace("sensors", "").Replace("sensor", "");
            return $"{SharedHelperFunctions.GetSafeConfiguredDeviceName()}_{sensorName}";
        }

        /// <summary>
        /// Returns the name of the sensortype, based on the provided devicename
        /// </summary>
        /// <param name="sensorType"></param>
        /// <param name="deviceName"></param>
        /// <returns></returns>
        public static string GetSensorName(this SensorType sensorType, string deviceName)
        {
            var sensorName = sensorType.ToString().ToLower().Replace("sensors", "").Replace("sensor", "");
            return $"{SharedHelperFunctions.GetSafeValue(deviceName)}_{sensorName}";
        }
    }
}