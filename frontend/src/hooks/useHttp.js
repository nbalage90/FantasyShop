import { useEffect, useState } from 'react';

const BASE_URL = 'http://localhost:6010/'; // TODO: paging

export function useHttp(route, initialValue, config) {
  const [data, setData] = useState(initialValue);
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState();

  useEffect(() => {
    async function fetchData() {
      setIsLoading(true);

      let url = BASE_URL + route;
      if (config && config.count) {
        url += '?pageSize=' + config.count;
      }

      try {
        const response = await fetch(url);
        const resData = await response.json();

        if (!response.ok) {
          setError(resData);
        } else {
          setData(resData);
        }
      } catch (error) {
        setError({
          title: 'Failed to load data',
          message: error.message,
          path: null,
        });
      }

      // TODO: hiba esetén maximalizálni a próbálkozások számát
      setIsLoading(false);
    }

    fetchData();
  }, [config, route]);

  return {
    data,
    isLoading,
    error,
  };
}
