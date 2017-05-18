﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Game.Configuration;
using osu.Game.Overlays.Settings;

namespace osu.Game.Screens.Play.Options
{
    public class PlaybackOptions : OptionContainer
    {
        public override string Title => @"PLAYBACK";

        [BackgroundDependencyLoader]
        private void load(OsuConfigManager config)
        {
            Add(new SettingsSlider<double>
            {
                LabelText = "Playback speed",
                Bindable = config.GetBindable<double>(OsuSetting.PlaybackSpeed),
            });
        }
    }
}
