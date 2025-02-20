/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// These settings relate to the fragmented MP4 container for the segments in your CMAF
    /// outputs.
    /// </summary>
    public partial class CmfcSettings
    {
        private CmfcAudioDuration _audioDuration;
        private string _audioGroupId;
        private string _audioRenditionSets;
        private CmfcAudioTrackType _audioTrackType;
        private CmfcDescriptiveVideoServiceFlag _descriptiveVideoServiceFlag;
        private CmfcIFrameOnlyManifest _iFrameOnlyManifest;
        private CmfcScte35Esam _scte35Esam;
        private CmfcScte35Source _scte35Source;

        /// <summary>
        /// Gets and sets the property AudioDuration. Specify this setting only when your output
        /// will be consumed by a downstream repackaging workflow that is sensitive to very small
        /// duration differences between video and audio. For this situation, choose Match video
        /// duration (MATCH_VIDEO_DURATION). In all other cases, keep the default value, Default
        /// codec duration (DEFAULT_CODEC_DURATION). When you choose Match video duration, MediaConvert
        /// pads the output audio streams with silence or trims them to ensure that the total
        /// duration of each audio stream is at least as long as the total duration of the video
        /// stream. After padding or trimming, the audio stream duration is no more than one frame
        /// longer than the video stream. MediaConvert applies audio padding or trimming only
        /// to the end of the last segment of the output. For unsegmented outputs, MediaConvert
        /// adds padding only to the end of the file. When you keep the default value, any minor
        /// discrepancies between audio and video duration will depend on your output audio codec.
        /// </summary>
        public CmfcAudioDuration AudioDuration
        {
            get { return this._audioDuration; }
            set { this._audioDuration = value; }
        }

        // Check to see if AudioDuration property is set
        internal bool IsSetAudioDuration()
        {
            return this._audioDuration != null;
        }

        /// <summary>
        /// Gets and sets the property AudioGroupId. Specify the audio rendition group for this
        /// audio rendition. Specify up to one value for each audio output in your output group.
        /// This value appears in your HLS parent manifest in the EXT-X-MEDIA tag of TYPE=AUDIO,
        /// as the value for the GROUP-ID attribute. For example, if you specify "audio_aac_1"
        /// for Audio group ID, it appears in your manifest like this: #EXT-X-MEDIA:TYPE=AUDIO,GROUP-ID="audio_aac_1".
        /// Related setting: To associate the rendition group that this audio track belongs to
        /// with a video rendition, include the same value that you provide here for that video
        /// output's setting Audio rendition sets (audioRenditionSets).
        /// </summary>
        public string AudioGroupId
        {
            get { return this._audioGroupId; }
            set { this._audioGroupId = value; }
        }

        // Check to see if AudioGroupId property is set
        internal bool IsSetAudioGroupId()
        {
            return this._audioGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AudioRenditionSets. List the audio rendition groups that
        /// you want included with this video rendition. Use a comma-separated list. For example,
        /// say you want to include the audio rendition groups that have the audio group IDs "audio_aac_1"
        /// and "audio_dolby". Then you would specify this value: "audio_aac_1,audio_dolby". Related
        /// setting: The rendition groups that you include in your comma-separated list should
        /// all match values that you specify in the setting Audio group ID (AudioGroupId) for
        /// audio renditions in the same output group as this video rendition. Default behavior:
        /// If you don't specify anything here and for Audio group ID, MediaConvert puts each
        /// audio variant in its own audio rendition group and associates it with every video
        /// variant. Each value in your list appears in your HLS parent manifest in the EXT-X-STREAM-INF
        /// tag as the value for the AUDIO attribute. To continue the previous example, say that
        /// the file name for the child manifest for your video rendition is "amazing_video_1.m3u8".
        /// Then, in your parent manifest, each value will appear on separate lines, like this:
        /// #EXT-X-STREAM-INF:AUDIO="audio_aac_1"... amazing_video_1.m3u8 #EXT-X-STREAM-INF:AUDIO="audio_dolby"...
        /// amazing_video_1.m3u8
        /// </summary>
        public string AudioRenditionSets
        {
            get { return this._audioRenditionSets; }
            set { this._audioRenditionSets = value; }
        }

        // Check to see if AudioRenditionSets property is set
        internal bool IsSetAudioRenditionSets()
        {
            return this._audioRenditionSets != null;
        }

        /// <summary>
        /// Gets and sets the property AudioTrackType. Use this setting to control the values
        /// that MediaConvert puts in your HLS parent playlist to control how the client player
        /// selects which audio track to play. The other options for this setting determine the
        /// values that MediaConvert writes for the DEFAULT and AUTOSELECT attributes of the EXT-X-MEDIA
        /// entry for the audio variant. For more information about these attributes, see the
        /// Apple documentation article https://developer.apple.com/documentation/http_live_streaming/example_playlists_for_http_live_streaming/adding_alternate_media_to_a_playlist.
        /// Choose Alternate audio, auto select, default (ALTERNATE_AUDIO_AUTO_SELECT_DEFAULT)
        /// to set DEFAULT=YES and AUTOSELECT=YES. Choose this value for only one variant in your
        /// output group. Choose Alternate audio, auto select, not default (ALTERNATE_AUDIO_AUTO_SELECT)
        /// to set DEFAULT=NO and AUTOSELECT=YES. Choose Alternate Audio, Not Auto Select to set
        /// DEFAULT=NO and AUTOSELECT=NO. When you don't specify a value for this setting, MediaConvert
        /// defaults to Alternate audio, auto select, default. When there is more than one variant
        /// in your output group, you must explicitly choose a value for this setting.
        /// </summary>
        public CmfcAudioTrackType AudioTrackType
        {
            get { return this._audioTrackType; }
            set { this._audioTrackType = value; }
        }

        // Check to see if AudioTrackType property is set
        internal bool IsSetAudioTrackType()
        {
            return this._audioTrackType != null;
        }

        /// <summary>
        /// Gets and sets the property DescriptiveVideoServiceFlag. Specify whether to flag this
        /// audio track as descriptive video service (DVS) in your HLS parent manifest. When you
        /// choose Flag (FLAG), MediaConvert includes the parameter CHARACTERISTICS="public.accessibility.describes-video"
        /// in the EXT-X-MEDIA entry for this track. When you keep the default choice, Don't flag
        /// (DONT_FLAG), MediaConvert leaves this parameter out. The DVS flag can help with accessibility
        /// on Apple devices. For more information, see the Apple documentation.
        /// </summary>
        public CmfcDescriptiveVideoServiceFlag DescriptiveVideoServiceFlag
        {
            get { return this._descriptiveVideoServiceFlag; }
            set { this._descriptiveVideoServiceFlag = value; }
        }

        // Check to see if DescriptiveVideoServiceFlag property is set
        internal bool IsSetDescriptiveVideoServiceFlag()
        {
            return this._descriptiveVideoServiceFlag != null;
        }

        /// <summary>
        /// Gets and sets the property IFrameOnlyManifest. Choose Include (INCLUDE) to have MediaConvert
        /// generate an HLS child manifest that lists only the I-frames for this rendition, in
        /// addition to your regular manifest for this rendition. You might use this manifest
        /// as part of a workflow that creates preview functions for your video. MediaConvert
        /// adds both the I-frame only child manifest and the regular child manifest to the parent
        /// manifest. When you don't need the I-frame only child manifest, keep the default value
        /// Exclude (EXCLUDE).
        /// </summary>
        public CmfcIFrameOnlyManifest IFrameOnlyManifest
        {
            get { return this._iFrameOnlyManifest; }
            set { this._iFrameOnlyManifest = value; }
        }

        // Check to see if IFrameOnlyManifest property is set
        internal bool IsSetIFrameOnlyManifest()
        {
            return this._iFrameOnlyManifest != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Esam. Use this setting only when you specify SCTE-35
        /// markers from ESAM. Choose INSERT to put SCTE-35 markers in this output at the insertion
        /// points that you specify in an ESAM XML document. Provide the document in the setting
        /// SCC XML (sccXml).
        /// </summary>
        public CmfcScte35Esam Scte35Esam
        {
            get { return this._scte35Esam; }
            set { this._scte35Esam = value; }
        }

        // Check to see if Scte35Esam property is set
        internal bool IsSetScte35Esam()
        {
            return this._scte35Esam != null;
        }

        /// <summary>
        /// Gets and sets the property Scte35Source. Ignore this setting unless you have SCTE-35
        /// markers in your input video file. Choose Passthrough (PASSTHROUGH) if you want SCTE-35
        /// markers that appear in your input to also appear in this output. Choose None (NONE)
        /// if you don't want those SCTE-35 markers in this output.
        /// </summary>
        public CmfcScte35Source Scte35Source
        {
            get { return this._scte35Source; }
            set { this._scte35Source = value; }
        }

        // Check to see if Scte35Source property is set
        internal bool IsSetScte35Source()
        {
            return this._scte35Source != null;
        }

    }
}