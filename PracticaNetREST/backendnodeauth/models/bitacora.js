'use strict';
const {
  Model
} = require('sequelize');
module.exports = (sequelize, DataTypes) => {
  class bitacora extends Model {
    static associate(models) {
      // define association here
    }
  }
  bitacora.init({
    id: {
      type: DataTypes.STRING,
      autoIncrement: true,
      primaryKey: true
    },
    titulo: {
      type: DataTypes.STRING,
      allowNull: false
    },
    descripcion:{
      type: DataTypes.STRING,
      allowNull: false
    }
  }, {
    sequelize,
    freezeTableName: true,
    modelName: 'bitacora',
  });
  return bitacora;
};