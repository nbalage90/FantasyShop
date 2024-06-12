import { useEffect, useState } from 'react';

export function useHttp(initialValue, config) {
  const [data, setData] = useState(initialValue);
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState();

  useEffect(() => {
    async function fetchData() {
      setIsLoading(true);

      let url = 'http://localhost:8000/products';
      if (config && config.count) {
        url += '?count=' + config.count;
      }
      const response = await fetch(url);
      const resData = await response.json();

      if (!response.ok) {
        setError(response.message || 'Could not fetch the data.');
      }

      setData(resData);
      setIsLoading(false);
    }

    fetchData();
  }, [config]);

  return {
    data,
    isLoading,
    error,
  };
}
