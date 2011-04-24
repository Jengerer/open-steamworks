// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientMatchmakingVTable
	{
		public IntPtr GetFavoriteGameCount0;
		public IntPtr GetFavoriteGame1;
		public IntPtr AddFavoriteGame2;
		public IntPtr RemoveFavoriteGame3;
		public IntPtr RequestLobbyList4;
		public IntPtr AddRequestLobbyListStringFilter5;
		public IntPtr AddRequestLobbyListNumericalFilter6;
		public IntPtr AddRequestLobbyListNearValueFilter7;
		public IntPtr AddRequestLobbyListFilterSlotsAvailable8;
		public IntPtr AddRequestLobbyListDistanceFilter9;
		public IntPtr AddRequestLobbyListResultCountFilter10;
		public IntPtr GetLobbyByIndex11;
		public IntPtr CreateLobby12;
		public IntPtr JoinLobby13;
		public IntPtr LeaveLobby14;
		public IntPtr InviteUserToLobby15;
		public IntPtr GetNumLobbyMembers16;
		public IntPtr GetLobbyMemberByIndex17;
		public IntPtr GetLobbyData18;
		public IntPtr SetLobbyData19;
		public IntPtr GetLobbyDataCount20;
		public IntPtr GetLobbyDataByIndex21;
		public IntPtr DeleteLobbyData22;
		public IntPtr GetLobbyMemberData23;
		public IntPtr SetLobbyMemberData24;
		public IntPtr SendLobbyChatMsg25;
		public IntPtr GetLobbyChatEntry26;
		public IntPtr RequestLobbyData27;
		public IntPtr SetLobbyGameServer28;
		public IntPtr GetLobbyGameServer29;
		public IntPtr SetLobbyMemberLimit30;
		public IntPtr GetLobbyMemberLimit31;
		public IntPtr SetLobbyVoiceEnabled32;
		public IntPtr RequestFriendsLobbies33;
		public IntPtr SetLobbyType34;
		public IntPtr SetLobbyJoinable35;
		public IntPtr GetLobbyOwner36;
		public IntPtr SetLobbyOwner37;
		public IntPtr GetGMSServerCount38;
		public IntPtr GetGMSServerAddress39;
		private IntPtr DTorIClientMatchmaking40;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTMATCHMAKING_INTERFACE_VERSION001")]
	public class IClientMatchmaking : InteropHelp.NativeWrapper<IClientMatchmakingVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFavoriteGameCount( IntPtr thisptr );
		public Int32 GetFavoriteGameCount(  ) 
		{
			return this.GetFunction<NativeGetFavoriteGameCount>( this.Functions.GetFavoriteGameCount0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFavoriteGameIUUUUUU( IntPtr thisptr, Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetFavoriteGame( Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer ) 
		{
			return this.GetFunction<NativeGetFavoriteGameIUUUUUU>( this.Functions.GetFavoriteGame1 )( this.ObjectAddress, iGame, ref pnAppID, ref pnIP, ref pnConnPort, ref pnQueryPort, ref punFlags, ref pRTime32LastPlayedOnServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeAddFavoriteGameUUUUUU( IntPtr thisptr, UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer );
		public Int32 AddFavoriteGame( UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer ) 
		{
			return this.GetFunction<NativeAddFavoriteGameUUUUUU>( this.Functions.AddFavoriteGame2 )( this.ObjectAddress, nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveFavoriteGameUUUUU( IntPtr thisptr, UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RemoveFavoriteGame( UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags ) 
		{
			return this.GetFunction<NativeRemoveFavoriteGameUUUUU>( this.Functions.RemoveFavoriteGame3 )( this.ObjectAddress, nAppID, nIP, nConnPort, nQueryPort, unFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestLobbyList( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 RequestLobbyList(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeRequestLobbyList>( this.Functions.RequestLobbyList4 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListStringFilterSSE( IntPtr thisptr, string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType );
		public void AddRequestLobbyListStringFilter( string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType ) 
		{
			this.GetFunction<NativeAddRequestLobbyListStringFilterSSE>( this.Functions.AddRequestLobbyListStringFilter5 )( this.ObjectAddress, pchKeyToMatch, pchValueToMatch, eComparisonType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListNumericalFilterSIE( IntPtr thisptr, string pchKeyToMatch, Int32 nValueToMatch, ELobbyComparison eComparisonType );
		public void AddRequestLobbyListNumericalFilter( string pchKeyToMatch, Int32 nValueToMatch, ELobbyComparison eComparisonType ) 
		{
			this.GetFunction<NativeAddRequestLobbyListNumericalFilterSIE>( this.Functions.AddRequestLobbyListNumericalFilter6 )( this.ObjectAddress, pchKeyToMatch, nValueToMatch, eComparisonType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListNearValueFilterSI( IntPtr thisptr, string pchKeyToMatch, Int32 nValueToBeCloseTo );
		public void AddRequestLobbyListNearValueFilter( string pchKeyToMatch, Int32 nValueToBeCloseTo ) 
		{
			this.GetFunction<NativeAddRequestLobbyListNearValueFilterSI>( this.Functions.AddRequestLobbyListNearValueFilter7 )( this.ObjectAddress, pchKeyToMatch, nValueToBeCloseTo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListFilterSlotsAvailableI( IntPtr thisptr, Int32 nSlotsAvailable );
		public void AddRequestLobbyListFilterSlotsAvailable( Int32 nSlotsAvailable ) 
		{
			this.GetFunction<NativeAddRequestLobbyListFilterSlotsAvailableI>( this.Functions.AddRequestLobbyListFilterSlotsAvailable8 )( this.ObjectAddress, nSlotsAvailable ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListDistanceFilterE( IntPtr thisptr, ELobbyDistanceFilter filter );
		public void AddRequestLobbyListDistanceFilter( ELobbyDistanceFilter filter ) 
		{
			this.GetFunction<NativeAddRequestLobbyListDistanceFilterE>( this.Functions.AddRequestLobbyListDistanceFilter9 )( this.ObjectAddress, filter ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListResultCountFilterI( IntPtr thisptr, Int32 cMaxResults );
		public void AddRequestLobbyListResultCountFilter( Int32 cMaxResults ) 
		{
			this.GetFunction<NativeAddRequestLobbyListResultCountFilterI>( this.Functions.AddRequestLobbyListResultCountFilter10 )( this.ObjectAddress, cMaxResults ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyByIndexI( IntPtr thisptr, ref UInt64 retarg, Int32 iLobby );
		public CSteamID GetLobbyByIndex( Int32 iLobby ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetLobbyByIndexI>( this.Functions.GetLobbyByIndex11 )( this.ObjectAddress, ref ret, iLobby ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCreateLobbyEI( IntPtr thisptr, ref UInt64 retarg, ELobbyType eLobbyType, Int32 cMaxMembers );
		public UInt64 CreateLobby( ELobbyType eLobbyType, Int32 cMaxMembers ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeCreateLobbyEI>( this.Functions.CreateLobby12 )( this.ObjectAddress, ref ret, eLobbyType, cMaxMembers ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeJoinLobbyC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDLobby );
		public UInt64 JoinLobby( CSteamID steamIDLobby ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeJoinLobbyC>( this.Functions.JoinLobby13 )( this.ObjectAddress, ref ret, steamIDLobby.ConvertToUint64() ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLeaveLobbyC( IntPtr thisptr, UInt64 steamIDLobby );
		public void LeaveLobby( CSteamID steamIDLobby ) 
		{
			this.GetFunction<NativeLeaveLobbyC>( this.Functions.LeaveLobby14 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInviteUserToLobbyCC( IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDInvitee );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool InviteUserToLobby( CSteamID steamIDLobby, CSteamID steamIDInvitee ) 
		{
			return this.GetFunction<NativeInviteUserToLobbyCC>( this.Functions.InviteUserToLobby15 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDInvitee.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNumLobbyMembersC( IntPtr thisptr, UInt64 steamIDLobby );
		public Int32 GetNumLobbyMembers( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeGetNumLobbyMembersC>( this.Functions.GetNumLobbyMembers16 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyMemberByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDLobby, Int32 iMember );
		public CSteamID GetLobbyMemberByIndex( CSteamID steamIDLobby, Int32 iMember ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetLobbyMemberByIndexCI>( this.Functions.GetLobbyMemberByIndex17 )( this.ObjectAddress, ref ret, steamIDLobby.ConvertToUint64(), iMember ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLobbyDataCS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey );
		public string GetLobbyData( CSteamID steamIDLobby, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLobbyDataCS>( this.Functions.GetLobbyData18 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyDataCSS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey, string pchValue );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLobbyData( CSteamID steamIDLobby, string pchKey, string pchValue ) 
		{
			return this.GetFunction<NativeSetLobbyDataCSS>( this.Functions.SetLobbyData19 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey, pchValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLobbyDataCountC( IntPtr thisptr, UInt64 steamIDLobby );
		public Int32 GetLobbyDataCount( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeGetLobbyDataCountC>( this.Functions.GetLobbyDataCount20 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLobbyDataByIndexCISISI( IntPtr thisptr, UInt64 steamIDLobby, Int32 iLobbyData, StringBuilder pchKey, Int32 cchKeyBufferSize, StringBuilder pchValue, Int32 cchValueBufferSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetLobbyDataByIndex( CSteamID steamIDLobby, Int32 iLobbyData, StringBuilder pchKey, StringBuilder pchValue ) 
		{
			return this.GetFunction<NativeGetLobbyDataByIndexCISISI>( this.Functions.GetLobbyDataByIndex21 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), iLobbyData, pchKey, (Int32) pchKey.Capacity, pchValue, (Int32) pchValue.Capacity ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeDeleteLobbyDataCS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool DeleteLobbyData( CSteamID steamIDLobby, string pchKey ) 
		{
			return this.GetFunction<NativeDeleteLobbyDataCS>( this.Functions.DeleteLobbyData22 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLobbyMemberDataCCS( IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDUser, string pchKey );
		public string GetLobbyMemberData( CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLobbyMemberDataCCS>( this.Functions.GetLobbyMemberData23 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDUser.ConvertToUint64(), pchKey ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyMemberDataCSS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey, string pchValue );
		public void SetLobbyMemberData( CSteamID steamIDLobby, string pchKey, string pchValue ) 
		{
			this.GetFunction<NativeSetLobbyMemberDataCSS>( this.Functions.SetLobbyMemberData24 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey, pchValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendLobbyChatMsgCBI( IntPtr thisptr, UInt64 steamIDLobby, Byte[] pvMsgBody, Int32 cubMsgBody );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendLobbyChatMsg( CSteamID steamIDLobby, Byte[] pvMsgBody ) 
		{
			return this.GetFunction<NativeSendLobbyChatMsgCBI>( this.Functions.SendLobbyChatMsg25 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pvMsgBody, (Int32) pvMsgBody.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLobbyChatEntryCICBIE( IntPtr thisptr, UInt64 steamIDLobby, Int32 iChatID, ref UInt64 pSteamIDUser, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType );
		public Int32 GetLobbyChatEntry( CSteamID steamIDLobby, Int32 iChatID, ref CSteamID pSteamIDUser, Byte[] pvData, ref EChatEntryType peChatEntryType ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetLobbyChatEntryCICBIE>( this.Functions.GetLobbyChatEntry26 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), iChatID, ref s0, pvData, (Int32) pvData.Length, ref peChatEntryType ); pSteamIDUser = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestLobbyDataC( IntPtr thisptr, UInt64 steamIDLobby );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RequestLobbyData( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeRequestLobbyDataC>( this.Functions.RequestLobbyData27 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyGameServerCUUC( IntPtr thisptr, UInt64 steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, UInt64 steamIDGameServer );
		public void SetLobbyGameServer( CSteamID steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, CSteamID steamIDGameServer ) 
		{
			this.GetFunction<NativeSetLobbyGameServerCUUC>( this.Functions.SetLobbyGameServer28 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), unGameServerIP, unGameServerPort, steamIDGameServer.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLobbyGameServerCUUC( IntPtr thisptr, UInt64 steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref UInt64 psteamIDGameServer );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetLobbyGameServer( CSteamID steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref CSteamID psteamIDGameServer ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetLobbyGameServerCUUC>( this.Functions.GetLobbyGameServer29 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), ref punGameServerIP, ref punGameServerPort, ref s0 ); psteamIDGameServer = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyMemberLimitCI( IntPtr thisptr, UInt64 steamIDLobby, Int32 cMaxMembers );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLobbyMemberLimit( CSteamID steamIDLobby, Int32 cMaxMembers ) 
		{
			return this.GetFunction<NativeSetLobbyMemberLimitCI>( this.Functions.SetLobbyMemberLimit30 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), cMaxMembers ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLobbyMemberLimitC( IntPtr thisptr, UInt64 steamIDLobby );
		public Int32 GetLobbyMemberLimit( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeGetLobbyMemberLimitC>( this.Functions.GetLobbyMemberLimit31 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyVoiceEnabledCB( IntPtr thisptr, UInt64 steamIDLobby, [MarshalAs(UnmanagedType.I1)] bool bVoiceEnabled );
		public void SetLobbyVoiceEnabled( CSteamID steamIDLobby, bool bVoiceEnabled ) 
		{
			this.GetFunction<NativeSetLobbyVoiceEnabledCB>( this.Functions.SetLobbyVoiceEnabled32 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), bVoiceEnabled ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestFriendsLobbies( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RequestFriendsLobbies(  ) 
		{
			return this.GetFunction<NativeRequestFriendsLobbies>( this.Functions.RequestFriendsLobbies33 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyTypeCE( IntPtr thisptr, UInt64 steamIDLobby, ELobbyType eLobbyType );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLobbyType( CSteamID steamIDLobby, ELobbyType eLobbyType ) 
		{
			return this.GetFunction<NativeSetLobbyTypeCE>( this.Functions.SetLobbyType34 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), eLobbyType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyJoinableCB( IntPtr thisptr, UInt64 steamIDLobby, [MarshalAs(UnmanagedType.I1)] bool bLobbyJoinable );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLobbyJoinable( CSteamID steamIDLobby, bool bLobbyJoinable ) 
		{
			return this.GetFunction<NativeSetLobbyJoinableCB>( this.Functions.SetLobbyJoinable35 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), bLobbyJoinable ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyOwnerC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDLobby );
		public CSteamID GetLobbyOwner( CSteamID steamIDLobby ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetLobbyOwnerC>( this.Functions.GetLobbyOwner36 )( this.ObjectAddress, ref ret, steamIDLobby.ConvertToUint64() ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyOwnerCC( IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDNewOwner );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLobbyOwner( CSteamID steamIDLobby, CSteamID steamIDNewOwner ) 
		{
			return this.GetFunction<NativeSetLobbyOwnerCC>( this.Functions.SetLobbyOwner37 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDNewOwner.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetGMSServerCount( IntPtr thisptr );
		public Int32 GetGMSServerCount(  ) 
		{
			return this.GetFunction<NativeGetGMSServerCount>( this.Functions.GetGMSServerCount38 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetGMSServerAddressIUU( IntPtr thisptr, Int32 iServer, ref UInt32 unServerIP, ref UInt16 usServerPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetGMSServerAddress( Int32 iServer, ref UInt32 unServerIP, ref UInt16 usServerPort ) 
		{
			return this.GetFunction<NativeGetGMSServerAddressIUU>( this.Functions.GetGMSServerAddress39 )( this.ObjectAddress, iServer, ref unServerIP, ref usServerPort ); 
		}
		
	};
}
