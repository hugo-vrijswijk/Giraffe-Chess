Feature: SetChessPieces
	As a Chessplayes I want chesspieces to play with.

Background: 
Given A chess board with '8' x '8' tiles

Scenario: Set chesspieces
	Given A set of all the chess set pieces on each team side.
	When The chessboard is loaded successfully
	Then The result on the chessboard should be filled on both team sides to start the game.
