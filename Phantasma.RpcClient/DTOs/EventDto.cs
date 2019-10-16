﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Phantasma.RpcClient.DTOs
{
    public class EventDto
    {
        [JsonProperty("address")]
        public string EventAddress { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EventKind EventKind { get; set; }
    }

    public enum EventKind
    {
        Unknown = 0,
        ChainCreate = 1,
        TokenCreate = 2,
        TokenSend = 3,
        TokenReceive = 4,
        TokenMint = 5,
        TokenBurn = 6,
        TokenStake = 7,
        TokenClaim = 8,
        AddressRegister = 9,
        AddressLink = 10,
        AddressUnlink = 11,
        OrganizationCreate = 12,
        OrganizationAdd = 13,
        OrganizationRemove = 14,
        GasEscrow = 15,
        GasPayment = 16,
        AddressUnregister = 17,
        OrderCreated = 18,
        OrderCancelled = 19,
        OrderFilled = 20,
        OrderClosed = 21,
        FeedCreate = 22,
        FeedUpdate = 23,
        FileCreate = 24,
        FileDelete = 25,
        ValidatorPropose = 26,
        ValidatorElect = 27,
        ValidatorRemove = 28,
        ValidatorSwitch = 29,
        PackedNFT = 30,
        ValueCreate = 31,
        ValueUpdate = 32,
        PollCreated = 33,
        PollClosed = 34,
        PollVote = 35,
        ChannelCreate = 36,
        ChannelRefill = 37,
        ChannelSettle = 38,
        LeaderboardCreate = 39,
        LeaderboardInsert = 40,
        LeaderboardReset = 41,
        PlatformCreate = 42,
        ChainSwap = 43,
        ContractRegister = 44,
        ContractDeploy = 45,
        AddressMigration = 46,
        ContractUpgrade = 47,
        Log = 48,
        Custom = 64,
    }
}
