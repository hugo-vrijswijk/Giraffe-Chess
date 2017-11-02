Feature: SetChessPieces
	As a Chessplayes I want chesspieces to play with.


@mytag
Scenario: Set chesspieces
	Given A set of all the chess set pieces on each team side.
	When The chessboard is loaded successfully
	Then The result on the chessboard should be filled on both team sides to start the game.
