﻿/* This file is part of libWiiSharp
 * Copyright (C) 2009 Leathl
 * Copyright (C) 2020 - 2022 TheShadowEevee, Github Contributors
 * 
 * libWiiSharp is free software: you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * libWiiSharp is distributed in the hope that it will be
 * useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace libWiiSharp
{
    public class CommonKey
    {
        private static readonly string standardKey = "ebe42a225e8593e448d9c5457381aaf7";
        private static readonly string koreanKey = "63b82bb4f4614e2e13f2fefbba4c9b7e";
        private static readonly string vwiiKey = "30bfc76e7c19afbb23163330ced7c28d";

        public static byte[] GetStandardKey()
        {
            return Shared.HexStringToByteArray(standardKey);
        }

        public static byte[] GetKoreanKey()
        {
            return Shared.HexStringToByteArray(koreanKey);
        }

        public static byte[] GetvWiiKey()
        {
            return Shared.HexStringToByteArray(vwiiKey);
        }
    }
}
