Feature: CreateBoard
As a chessplayer I want a chessboard I can play on.

Scenario: Create the chess board
	Given A chess board with '8' x '8' tiles
	When The chessplayer starts the game
	Then The chess board with '64' tiles would be created.

