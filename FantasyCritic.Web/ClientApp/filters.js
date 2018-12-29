import Vue from 'vue';
import moment from 'moment';

Vue.filter('score', function (value, decimals) {
  if (value === 0) {
    return 0;
  }
  if (!value) {
    return "--";
  }

  if (!decimals) {
    decimals = 0;
  }

  value = Math.round(value * Math.pow(10, decimals)) / Math.pow(10, decimals);
  return value;
});

Vue.filter('money', function (value) {
  if (typeof value !== "number") {
    return value;
  }
  var formatter = new Intl.NumberFormat('en-US', {
    style: 'currency',
    currency: 'USD',
    minimumFractionDigits: 0
  });
  return formatter.format(value);
});

Vue.filter('date', function(value) {
  if (value) {
    return moment(String(value)).format('MM/DD/YYYY hh:mm');
  }
  return "";
});

Vue.filter('yesNo', function (value) {
  if (value) {
    return "Yes";
  }
  return "No";
});
