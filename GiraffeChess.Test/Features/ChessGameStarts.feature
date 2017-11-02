Feature: ChessGameStarts
 As a chess player I want to get started with the game a color black or white.

 Background: 
 Given A chess board with '8' x '8' tiles
 Given A set of all the chess set pieces on each team side.

Scenario: Start the game
	Given The new board is created
	When The chessboard is loaded with chesspieces
	Then The side white should be chosen
