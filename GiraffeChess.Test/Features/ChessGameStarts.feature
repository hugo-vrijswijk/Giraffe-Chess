Feature: ChessGameStarts
 As a chess player I want to get started with the game a color black or white.

Scenario: Start the game
	Given A new board is created
	When The chessboard is loaded with chesspieces
	Then The side white should be chosen
