const path = require('path');

module.exports = {
  mode: 'development',
  entry: {
    home: './src/pages/home/index.ts',
    empresa: './src/pages/empresa/index.ts'
  },
  output: {
    filename: '[name].entry.js',
    path: path.resolve(__dirname, 'wwwroot/dist'),
    library: ['timer', '[name]'],
  },
  module: {
    rules: [
      {
        test: /\.tsx?$/,
        use: 'ts-loader',
        exclude: /node_modules/,
      },
      {
        test: /\.css$/i,
        use: ['style-loader', 'css-loader'],
      },
    ],
  },
  resolve: {
    extensions: ['.tsx', '.ts', '.js', '.css'],
  },
};
