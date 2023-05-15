/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2022-23 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using FluentAssertions;
using SmartBlazor.Service;
using Xunit;

namespace SmartBlazor.Tests
{
    public class SiteUserTest
    {
        [Fact]
        public void InsertNewUserTest()
        {
            var _userService = new SiteUserService();
            _userService.AddUser("pippo", "pluto");
            var _userPippo = _userService.GetUser("pippo");

            _userPippo.Should().NotBeNull();
            _userPippo!.Password.Should().Be("pluto");
        }
    }
}